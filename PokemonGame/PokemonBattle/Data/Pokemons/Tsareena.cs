using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Tsareena : Pokemon
{
	public override string Name => "Tsareena";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard(), new Abilities.Queenlymajesty() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sweetveil() };
	public override Stats BaseStats => new Stats(72, 120, 98, 50, 98, 72);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Tropkick() },
		[1] = new List<Move>() { new Moves.Tropkick(), new Moves.Powerwhip(), new Moves.Flail(), new Moves.Playnice(), new Moves.Splash(), new Moves.Swagger(), new Moves.Rapidspin(), new Moves.Razorleaf() },
		[16] = new List<Move>() { new Moves.Sweetscent() },
		[22] = new List<Move>() { new Moves.Magicalleaf() },
		[28] = new List<Move>() { new Moves.Stomp() },
		[34] = new List<Move>() { new Moves.Teeterdance() },
		[40] = new List<Move>() { new Moves.Aromaticmist() },
		[46] = new List<Move>() { new Moves.Aromatherapy() },
		[52] = new List<Move>() { new Moves.Leafstorm() },
		[58] = new List<Move>() { new Moves.Highjumpkick() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Bounce(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Payback(), new Moves.Playrough(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Tripleaxel(), new Moves.Uturn(), new Moves.Zenheadbutt() };
	public override int Weight => 214;
	public override int ExpYield => 255;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 3,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}