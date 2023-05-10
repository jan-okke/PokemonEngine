using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Jirachi : Pokemon
{
	public override string Name => "Jirachi";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Serenegrace() };
	public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Wish() },
		[7] = new List<Move>() { new Moves.Swift() },
		[14] = new List<Move>() { new Moves.Helpinghand() },
		[21] = new List<Move>() { new Moves.Lifedew() },
		[28] = new List<Move>() { new Moves.Zenheadbutt() },
		[35] = new List<Move>() { new Moves.Gravity() },
		[42] = new List<Move>() { new Moves.Psychic() },
		[49] = new List<Move>() { new Moves.Meteormash() },
		[56] = new List<Move>() { new Moves.Healingwish() },
		[63] = new List<Move>() { new Moves.Rest() },
		[70] = new List<Move>() { new Moves.Futuresight() },
		[77] = new List<Move>() { new Moves.Doubleedge() },
		[84] = new List<Move>() { new Moves.Cosmicpower() },
		[91] = new List<Move>() { new Moves.Lastresort() },
		[98] = new List<Move>() { new Moves.Doomdesire() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cosmicpower(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Flashcannon(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Meteorbeam(), new Moves.Metronome(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Waterpulse(), new Moves.Zenheadbutt() };
	public override int Weight => 11;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}