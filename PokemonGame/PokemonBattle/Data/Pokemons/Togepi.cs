using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Togepi : Pokemon
{
	public override string Name => "Togepi";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Hustle(), new Abilities.Serenegrace() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Superluck() };
	public override Stats BaseStats => new Stats(35, 20, 65, 40, 65, 20);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Fairy };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Growl(), new Moves.Pound() },
		[4] = new List<Move>() { new Moves.Sweetkiss() },
		[8] = new List<Move>() { new Moves.Lifedew() },
		[12] = new List<Move>() { new Moves.Charm() },
		[16] = new List<Move>() { new Moves.Ancientpower() },
		[20] = new List<Move>() { new Moves.Yawn() },
		[24] = new List<Move>() { new Moves.Metronome() },
		[28] = new List<Move>() { new Moves.Afteryou() },
		[32] = new List<Move>() { new Moves.Doubleedge() },
		[36] = new List<Move>() { new Moves.Safeguard() },
		[40] = new List<Move>() { new Moves.Followme() },
		[44] = new List<Move>() { new Moves.Batonpass() },
		[48] = new List<Move>() { new Moves.Lastresort() },
		[52] = new List<Move>() { new Moves.Wish() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Futuresight(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Lightscreen(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Mysticalfire(), new Moves.Nastyplot(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Extrasensory(), new Moves.Futuresight(), new Moves.Morningsun(), new Moves.Peck(), new Moves.Present(), new Moves.Psychoshift(), new Moves.Storedpower() };
	public override int Weight => 15;
	public override int ExpYield => 49;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}