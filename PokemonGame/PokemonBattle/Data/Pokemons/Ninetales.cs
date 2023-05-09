using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Ninetales : Pokemon
{
	public override string Name => "Ninetales";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Drought() };
	public override Stats BaseStats => new Stats(73, 76, 75, 81, 100, 100);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Nastyplot(), new Moves.Incinerate(), new Moves.Spite(), new Moves.Incinerate(), new Moves.Confuseray(), new Moves.Willowisp(), new Moves.Extrasensory(), new Moves.Flamethrower(), new Moves.Imprison(), new Moves.Firespin(), new Moves.Safeguard(), new Moves.Inferno(), new Moves.Grudge(), new Moves.Fireblast(), new Moves.Ember(), new Moves.Tailwhip(), new Moves.Disable(), new Moves.Quickattack() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Burningjealousy(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Foulplay(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Mysticalfire(), new Moves.Nastyplot(), new Moves.Overheat(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Rest(), new Moves.Roar(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Weatherball(), new Moves.Willowisp(), new Moves.Zenheadbutt() };
	public override int Weight => 199;
	public override int ExpYield => 177;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 1
	};
}