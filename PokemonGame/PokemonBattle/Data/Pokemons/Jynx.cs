using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Jynx : Pokemon
{
	public override string Name => "Jynx";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Forewarn() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Dryskin() };
	public override Stats BaseStats => new Stats(65, 50, 35, 115, 95, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ice, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Sweetkiss(), new Moves.Lick(), new Moves.Pound(), new Moves.Powdersnow(), new Moves.Copycat() },
		[12] = new List<Move>() { new Moves.Confusion() },
		[16] = new List<Move>() { new Moves.Covet() },
		[20] = new List<Move>() { new Moves.Sing() },
		[24] = new List<Move>() { new Moves.Faketears() },
		[28] = new List<Move>() { new Moves.Icepunch() },
		[34] = new List<Move>() { new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Lovelykiss() },
		[46] = new List<Move>() { new Moves.Meanlook() },
		[52] = new List<Move>() { new Moves.Perishsong() },
		[58] = new List<Move>() { new Moves.Blizzard() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override int Weight => 406;
	public override int ExpYield => 159;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}